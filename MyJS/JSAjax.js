

$('audio').audioPlayer(
    
{ 
    classPrefix: 'audioplayer', 
    strPlay: 'Play', 
    strPause: 'Pause', 
    strVolume: 'Volume'
    });



//function OnBegin() {
//    alert("Происходит отправка запроса");
//}
//function OnSuccess(data) {
//    alert("Запрос был успешно выполнен. Получены следующие данные: \n" + data);
//}
//function OnFailure(request, error) {
//    $("#results").html("Книги указанного автора не содержатся в базе данных.");
//}
//function OnComplete(request, status) {
//    alert("Статус запроса : " + status);
//}

//$(document).ready(function () {
//    $("#results").load("@Url.Action("BookSearch","Home")");
//});