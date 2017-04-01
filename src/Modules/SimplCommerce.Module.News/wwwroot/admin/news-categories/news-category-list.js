/*global angular, confirm*/
(function () {
    angular
        .module('simplAdmin.news')
        .controller('NewsCategoryListCtrl', NewsCategoryListCtrl);

    /* @ngInject */
    function NewsCategoryListCtrl(newsCategoryService) {
        var vm = this;
        vm.newsCategorys = [];

        vm.getNewsCategorys = function getNewsCategorys() {
            newsCategoryService.getNewsCategorys().then(function (result) {
                vm.newsCategorys = result.data;
            });
        };

        vm.deleteNewsCategory = function deleteNewsCategory(newsCategory) {
            bootbox.confirm('Are you sure you want to delete this news category: ' + newsCategory.name, function (result) {
                if (result) {
                    newsCategoryService.deleteNewsCategory(newsCategory)
                       .then(function (result) {
                           vm.getNewsCategorys();
                           toastr.success(newsCategory.name + ' has been deleted');
                       })
                       .catch(function (response) {
                           toastr.error(response.data.error);
                       });
                }
            });
        };

        vm.getNewsCategorys();
    }
})();