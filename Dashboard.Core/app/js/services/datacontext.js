export default ngModule => {
    var serviceId = 'datacontext';

    ngModule.factory(serviceId, function datacontext($http, $rootScope, $cookies, common){

        var service = {
            getHome : getHome
        };

        return service;

        function getHome(){
            return $http.get('homedata').then(_onSuccess);
        }

        function getCurrentUser(){
            return $http.get('user').then(_onSuccess);
        }

        function userLogin(user) {
            return $http.post('login', user).success(_onSuccess).error(_onError);
        }

        function _onSuccess(data){
            return data.data;
        }

        function _onError(data) {
            return data;
        }

    });
}
