function MahalleEkle() {
    
    var _koordinatlar = '';
    
    for (var i = 0; i < MahalleKoordinatlari[0].length; i++) {

        var _nokta = MahalleKoordinatlari[0][i];
        _koordinatlar += _nokta[0] + ' ' + _nokta[1] + ',';
    }
    $.ajax({
            url: '../Mahalle/Add',
        type: 'GET',
        data:
            {
                MahalleKodu: $('#mahalle_no').val(),
                MahalleAdi: $('#mahalle_adi').val(),
                Koordinatlar: _koordinatlar
            },
            success: function (result) {
              
                if (result) {
                    alert('işlem tamam');
                }
            }
        });
}
