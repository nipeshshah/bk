function SearchKoFn() {
    var self = this;
    self.Title = ko.observable('hekki');
    self.Temples = ko.observableArray([]);

    self.PopulateTemples = function (temples) {
        self.Temples.removeAll();
        temples.forEach(function (item) {
            self.Temples.push(new templeFn(item));
        });
    };
}

function templeFn(item) {
    var self = this;
    self.Id = ko.observable(item.Id);
    self.Title = ko.observable(item.Title);
    self.MoolnayakImage = ko.observable(item.MoolnayakImage);
    self.Moolnayak = ko.observable(item.Moolnayak);
    self.City = ko.observable(item.City);
    self.Trust = ko.observable(item.Trust);
    self.BhojanshalaCount = ko.observable(item.BhojanshalaCount);
    self.DharmshalaCount = ko.observable(item.DharmshalaCount);
    self.Idols = ko.observable(item.Idols);
    return self;
}