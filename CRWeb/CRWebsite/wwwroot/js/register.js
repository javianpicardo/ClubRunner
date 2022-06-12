$(function() {
    //populateRegion();
    $('#region').change(function () {
        var optionSelected = $(this);
        let valueSelected = optionSelected.val();
        if (valueSelected !== 'Select') {
            populateCountry(valueSelected);
        };        
    }); 
});

var populateRegion = function () {
    return new window.Promise(function (resolve, reject) {

        $.ajax({
            type: 'GET',
            async: true,
            url: 'https://restcountries.com/v3.1/region/'+'Americas',
            /*data: JSON.stringify(json),*/
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            error: function () {
                alert('Error retrieving Region from the server. Please contact support.');
                reject();
            },
            success: function (results) {
                $('#region > option').remove();
                $(results).each(function (index, region) {
                    $('#region').append(`<option value="${region.Id}">${region.Description}</option>`);
                });
                
                resolve();
            }
        });
    });
};


var populateCountry = function (regionSelected) {
    return new window.Promise(function (resolve, reject) {

        $.ajax({
            type: 'GET',
            async: true,
            url: 'https://restcountries.com/v3.1/region/' + regionSelected,
            /*data: JSON.stringify(json),*/
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            error: function () {
                alert('Error retrieving Country from the server. Please contact support.');
                reject();
            },
            success: function (results) {
                $('#country > option').remove();
                $(results).each(function (index, region) {
                    $('#country').append(`<option value="${region.name.common}">${region.name.common}</option>`);
                });
                resolve();
            }
        });
    });
};