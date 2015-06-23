export default ngModule => {
    var controllerId = 'home';

    ngModule.controller(controllerId, function ($location, $scope, $rootScope, $cookies, $interval, $q, common) {

        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;

        vm.title = "Home";

        vm.home = [];

        activate();

        function activate() {
            common.activateController([getHome()], controllerId)
                .then(function () {
                    log('Activated Home view');
                });
        }

        function getHome() {
            return datacontext.getHome().then(function (data) {
                vm.home = data;
                console.log(vm.home);
            })
        }

    });
}