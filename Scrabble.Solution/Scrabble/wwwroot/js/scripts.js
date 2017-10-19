$(document).ready(function(){
  var audio = new Audio ("/audio/train.mp3");
  $("#scrabble").click(function(){
    audio.play();
  });
});
