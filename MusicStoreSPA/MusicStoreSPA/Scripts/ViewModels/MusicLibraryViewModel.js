function MusicLibraryViewModel(config) {
    var
    Artists = ko.observableArray();
    LoadArtists = function () {
        $.ajax({
            url: config.LoadArtistsUrl,
            type: 'GET',
            success: function (data) {
                ko.mapping.fromJS(data, {}, Artists);
            }
        });
    };

    return {
        Artists: Artists,
        LoadArtists: LoadArtists
    };
};