(function(cmsModule,$){
    cmsModule.controller('MenuManagementCtrl', MenuManagementCtrl);
    function MenuManagementCtrl($scope, menuService) {
        function init() {
            $scope.status = {
                Category: true,
                Page: false,
                Brand : false
            };
            //$scope.$watch('status.isCategoriesOpen', function (scope) {
            //    if (scope) {
            //        for (var property in $scope.status) {
            //            $scope.status[property] = false;
            //        }
            //        $scope.status.isCategoriesOpen = true;
            //    }
            //});
            //$scope.$watch('status.isPagesOpen', function (scope) {
            //    if (scope) {
            //        for (var property in $scope.status) {
            //            $scope.status[property] = false;
            //        }
            //        $scope.status.isPagesOpen = true;
            //    }
            //});
            //$scope.$watch('status.isCustomLinksOpen', function (scope) {
            //    if (scope) {
            //        for (var property in $scope.status) {
            //            $scope.status[property] = false;
            //        }
            //        $scope.status.isCustomLinksOpen = true;
            //    }
            //});
            $scope.treeOptions = {
            };
            $scope.menuNodes = [];
            $scope.saveMenu = function () {

            }
            $scope.addToMenu = function (type) {
                //if (type == 'Category') {
                //    $($scope.categoryMenuItems).filter(function () {
                //        return this.isChecked;
                //    }).each(function (index, value) {
                //        $scope.categoryMenuItems[$scope.categoryMenuItems.indexOf(value)].isChecked = false;

                //        var menuNode = angular.copy(value);
                //        menuNode.type = type;
                //        menuNode.nodes = [];
                //        $scope.menuNodes.push(menuNode);
                //    });
                //} else if (type == 'Page') {
                //    $($scope.pageMenuItems).filter(function () {
                //        return this.isChecked;
                //    }).each(function (index, value) {
                //        $scope.pageMenuItems[$scope.pageMenuItems.indexOf(value)].isChecked = false;

                //        var menuNode = angular.copy(value);
                //        menuNode.type = type;
                //        menuNode.nodes = [];
                //        $scope.menuNodes.push(menuNode);
                //    });
                //}else if (type == 'Custom Link') {

                //}
            };  
            menuService.getMenuViewModel().then(function (results) {
                $scope.menuTypes = results.data;
            });
        }
        init();
    }
})(angular.module('simplAdmin.cms'),jQuery);