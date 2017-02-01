/*global angular*/
(function () {
    angular
        .module('simplAdmin.cms')
        .factory('menuService', MenuService);

    /* @ngInject */
    function MenuService($http) {
        var service = {
            getMenuViewModel: getMenuViewModel
        };
        return service;

        function getMenuViewModel() {
            return $http.get('api/menu');
        }
    }
})();