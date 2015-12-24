(function () {
    'use strict';

    var serviceId = 'datacontext';
    angular.module('app').factory(serviceId, ['common', 'entityManagerFactory', datacontext]);

    function datacontext(common, entityManagerFactory) {
        var $q = common.$q;
        var manager = entityManagerFactory.createManager();
        
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(serviceId);
        var logError = getLogFn(serviceId, 'error');
        var logSuccess = getLogFn(serviceId, 'success');

        var service = {
            addBookToOrder: addBookToOrder,
            changesCount: changesCount,
            createOrder: createOrder,
            getBooks: getBooks,
            getMessageCount: getMessageCount,
            getOrdersAndDetails: getOrdersAndDetails,
            getPeople: getPeople,
            isSaving: false,
            ready: getReady(),
            saveOrder: saveOrder
            
        };

        return service;

        function addBookToOrder(book, order) {
            if (!book || !order) {
                logError("Book or order not recieved!", null, true);
                return;
            }
            var detail = manager.createEntity("OrderDetail", {
                book: book,
                order: order,
                quantity: 1
            });
            return detail;
        };

        function createOrder() {
            manager.createEntity("Order", {
                orderDate:
                    new Date().toUTCString()
            });
            return order;
        };
        
        function changesCount() {
            return manager.getChanges().length;
        };

        function getBooks() {
            return breeze.EntityQuery.from('Books')
            .using(manager)
            .execute()
            .then(success)
            .catch(fail);

            function success(resp) {
                var book = resp.results;
                logSuccess("Hurray! We got books in our cart" + book.length, null, true);
                return getBooks;
            };
        }

        function fail(error) {
            logError('ooops we got' + error.message, error, true);
        };

        function getMessageCount() { return $q.when(72); }

        function getOrdersAndDetails() {
            return breeze.EntityQuery.from("Orders")
            .expand("orderDetails")
            .using(manager)
            .execute()
            .then(success)
            .catch(fail);


            function success(data) {
                var results = data.results;
                logSuccess("Yay!" + resultd.length + "orders", null, true)
                return (results);
            }
        };

        function getPeople() {
            var people = [
                { firstName: 'John', lastName: 'Papa', age: 25, location: 'Florida' },
                { firstName: 'Ward', lastName: 'Bell', age: 31, location: 'California' },
                { firstName: 'Colleen', lastName: 'Jones', age: 21, location: 'New York' },
                { firstName: 'Madelyn', lastName: 'Green', age: 18, location: 'North Dakota' },
                { firstName: 'Ella', lastName: 'Jobs', age: 18, location: 'South Dakota' },
                { firstName: 'Landon', lastName: 'Gates', age: 11, location: 'South Carolina' },
                { firstName: 'Haley', lastName: 'Guthrie', age: 35, location: 'Wyoming' }
            ];
            return $q.when(people);
        }

        function getReady() {
            return manager.metadataStore.fetchMetadata(manager.dataService)
            .then(function () {
                logSuccess("MetaData fetched!", null, true);
                return true;
            })
           .catch(function (error) {
               logError("MetaData fetch failed! We got + error.message, error, true")
               return $q.reject(error);
           });
        };

        function saveOrder() {
            isSaving: true;
            manager.saveChanges()
                .catch(saveFailed)
                .finally(saveFinally)
                .then(saveOrdersSuccess);
        }

        function saveFinally() {
            service.isSaving = false;
        };

        function saveFailed(error) {
            var msg = 'Save failed' + breeze.saveErrorMessageService.getErrorMessage(error);
            error.message = msg;
            logError(msg, error, true);
            throw error;
        };

        function saveOrdersSuccess(saveResult) {
            var order = saveResult.entities.filter(function(order) {
                return order.entityType.shortName === 'Order';
            })[0];
            var message = "Saved order" + order.customer;
            logSuccess(message, null, true);

            breeze.EntityQuery.from("Orders").where("id", "eq", order.id).expect("orderDetails")
                .using(manager)
                .execute()
                .then(function (data) {
                    var order = data.results[0];
                    var message = "Retrieved saved order" + order.customer +
                    "and his" + order.orderDetails.length + "books.";
                    logSuccess(message, order, true);
                })
        };
    }
})();