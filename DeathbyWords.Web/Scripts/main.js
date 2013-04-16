$(document).ready(function () {
    $('.sliderImg').hide();
    $('.sliderImg').attr('data-chosenImage', 'false');
    $('#sliderImg1').show();
    $('#sliderImg1').attr('data-chosenImage', 'true');
    setInterval(nextImage, 7000);
    $('.full-width').horizontalNav({});
    $('.akordeon').akordeon();
});

function nextImage() {
    if ($('#sliderImg1').attr('data-chosenImage') === 'true') {
        $('#sliderImg2').show("fade", {}, 2000);
        $('#sliderImg2').attr('data-chosenImage', 'true');
        $('#sliderImg1').hide();
        $('#sliderImg1').attr('data-chosenImage', 'false');
    } else if ($('#sliderImg2').attr('data-chosenImage') === 'true') {
        $('#sliderImg3').show("fade", {}, 2000);
        $('#sliderImg3').attr('data-chosenImage', 'true');
        $('#sliderImg2').hide();
        $('#sliderImg2').attr('data-chosenImage', 'false');
    } else if ($('#sliderImg3').attr('data-chosenImage') === 'true') {
        $('#sliderImg4').show("fade", {}, 2000);
        $('#sliderImg4').attr('data-chosenImage', 'true');
        $('#sliderImg3').hide();
        $('#sliderImg3').attr('data-chosenImage', 'false');
    } else if ($('#sliderImg4').attr('data-chosenImage') === 'true') {
        $('#sliderImg1').show("fade", {}, 2000);
        $('#sliderImg1').attr('data-chosenImage', 'true');
        $('#sliderImg4').hide();
        $('#sliderImg4').attr('data-chosenImage', 'false');
    }
}

