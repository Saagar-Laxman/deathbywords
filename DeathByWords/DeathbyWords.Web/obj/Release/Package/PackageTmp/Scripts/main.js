$(document).ready(function () {
    
    // Hide all images set to fade initially.
    $('.sliderImg').hide();
    $('.sliderImg').attr('data-chosenImage', 'false');
    
    //Then show first image. Not great, will think of a better way to do this.
    $('#sliderImg1').show();
    $('#sliderImg1').attr('data-chosenImage', 'true');

    //Set fade interval
    setInterval(nextImage, 4000);
    
    //Setup top nav
    $('.full-width').horizontalNav({});
    
    //Set up Akordeon
    $('.akordeon').akordeon();
});


//Fade between the images. Uses ID's. Should come up with a better way later.
function nextImage() {
    if ($('#sliderImg1').attr('data-chosenImage') === 'true') {
        $('#sliderImg1').attr('data-chosenImage', 'false');
        $('#sliderImg1').fadeOut(function() {
            $('#sliderImg2').fadeIn();
        });
        $('#sliderImg2').attr('data-chosenImage', 'true');
    } else if ($('#sliderImg2').attr('data-chosenImage') === 'true') {
        $('#sliderImg2').attr('data-chosenImage', 'false');
        $('#sliderImg2').fadeOut(function () {
            $('#sliderImg3').fadeIn();
        });
        $('#sliderImg3').attr('data-chosenImage', 'true');
    } else if ($('#sliderImg3').attr('data-chosenImage') === 'true') {
        $('#sliderImg3').attr('data-chosenImage', 'false');
        $('#sliderImg3').fadeOut(function () {
            $('#sliderImg1').fadeIn();
        });
        $('#sliderImg1').attr('data-chosenImage', 'true');
    }
}