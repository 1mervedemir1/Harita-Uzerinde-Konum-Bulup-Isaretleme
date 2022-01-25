//function KapiEkle() {
    
//    var Koordinatlar = '';

//    for (var i = 0; i < coordinate[0].lenght; i++) {

//        var nokta = coordinate[0][i];
//        Koordinatlar += nokta[0] + ' ' + nokta[1] + ',';
//    }

//    $.ajax({
//            url: '../Kapi/Add',
//        type: 'GET',
//        data:
//            {
//                KapiNo: $('#kapi_no').val(),
//                MahalleAdi: $('#mahalle_adi').val(),
//                koordinatlar: Koordinatlar
//            },
//            success: function (result) {
//                if (result) {
//                    alert('işlem tamam');
//                }
//            }
//    });
//}