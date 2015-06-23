export default ngModule => {
    require("./signalRHubProxy")(ngModule);
    require("./datacontext") (ngModule);
};