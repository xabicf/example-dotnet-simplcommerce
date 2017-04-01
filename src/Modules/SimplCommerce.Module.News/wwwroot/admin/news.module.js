/*global angular*/
(function () {
    'use strict';

    angular.module('simplAdmin.news', [])
        .config(['$stateProvider', function ($stateProvider) {
            $stateProvider
                .state('news-categories', {
                    url: '/news-categories',
                    templateUrl: 'modules/news/admin/news-categories/news-category-list.html',
                    controller: 'NewsCategoryListCtrl as vm'
                })
                .state('news-categories-create', {
                    url: '/news-categories/create',
                    templateUrl: 'modules/news/admin/news-categories/news-category-form.html',
                    controller: 'NewsCategoryFormCtrl as vm'
                })
                .state('news-categories-edit', {
                    url: '/news-categories/edit/:id',
                    templateUrl: 'modules/news/admin/news-categories/news-category-form.html',
                    controller: 'NewsCategoryFormCtrl as vm'
                });
        }]);
})();