//performs a fucntion --show meassage "ALL HAS LOADED" when the whole website and all its content has loaded
    $(window).on('load',function(){
        alert('ALL HAS LOADED');
        // this alerts a screen only when the whole website has loaded into memory(including the images and css etc) but before it is displayed
        // note the whole page is not displayed until after this function in the windows load has been executed and dealt with
        // so in essense it executes after all the components of the website has been loaded into memory, but this function executes first before display
    });

// DOM loader
    $(function(){

    });

// performs a function -- show message "JQUERY TUTORIAL" when the DOM has loaded
    $(function(){
        $('#button1').click(function(){
            alert('JQUERY TUTORIAL'); 
            // this alerts a screen only when DOM has loaded (excluding the css and images etc)  
        });
    });

//id selector
    //where id="button1"
    $('#button1')

// element selector
    //where tagname is a //anchor
    $('a') //selects all the a elements in the page
    $('div a') // selects all the a elements that are descendants of div element