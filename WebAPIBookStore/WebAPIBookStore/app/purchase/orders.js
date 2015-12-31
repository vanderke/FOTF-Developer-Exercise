﻿(function () {
    'use strict';
    var controllerId = 'orders';
    angular.module('app').controller(controllerId, ['common', 'datacontext', viewModel]);

    function viewModel(common, datacontext) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);
        var logIfo = getLogFn(controllerId, "info");
        var logSuccess = getLogFn(controllerId, "success");
        var theOrder = null;

        var vm = this;
        vm.orders = [];
        vm.showDetails = showDetails;
        vm.toggleDetails = toggleDetails;
        
        activate();

        function activate() {
            common.activateController([datacontext.ready], controllerId)
                .then(function () {
                    log('Activated Orders View');
                    createOrder();
                });
            logInfo("Getting Books....");
            datacontext.getBooks()
      
            datacontext.getOrdersAndDetails()
                  .then(function (orders) {
                      vm.orders = orders;
                  });
        }
        function showDetails(order) {
            return order === theOrder;
        };

        function toggleDetails(order) {
            theOrder = order === theOrder ? null : order;
            };
    }
})();