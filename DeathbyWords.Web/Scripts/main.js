$(document).ready(function () {
    
    // Hide all images set to fade initially.
    $('.sliderImg').hide();
    $('.sliderImg').attr('data-chosenImage', 'false');
    
    //Then show first image. Not great, will think of a better way to do this.
    $('#sliderImg1').show();
    $('#sliderImg1').attr('data-chosenImage', 'true');

    //Set fade interval
    setInterval(nextImage, 7000);
    
    //Setup top nav
    $('.full-width').horizontalNav({});
    
    //Set up Akordeon
    $('.akordeon').akordeon();
});

//Fade between the images. Uses ID's. Should come up with a better way later.
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

