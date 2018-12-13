var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('ABPDemoProject');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);