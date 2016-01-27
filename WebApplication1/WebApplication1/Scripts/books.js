angular.module('fotf', [
    'ngLocale',
    'books.services',
    'books.controllers'
]);

angular.module('books.services', ['ngResource'])
    .factory('Book', ['$resource',
      function ($resource) {
          return $resource('/api/Books/:bookId', { bookId: '@id' });
      }]);

angular.module('books.controllers', ['books.services'])
    .controller('BookListCtrl', [
        '$scope', 'Book',
        function ($scope, Book) {
            $scope.books = Book.query();
        }
    ])
    .controller('BookDetailCtrl', [
            '$scope', 'Book', '$attrs',
            function ($scope, Book, $attrs) {
                $scope.book = Book.get({bookId: $attrs.bookid});
            }
    ]);