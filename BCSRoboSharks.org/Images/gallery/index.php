<!doctype html>
<html lang="en">
<head>
  <meta charset="utf-8" />
  
  <title>Auto Grid Responsive Gallery</title>
  
  <meta name="viewport" content="width=device-width, initial-scale=1.0"> <!-- needed for mobile devices -->
  
  <!-- STYLE FOR FOR THE PLUGIN-->
  <link rel="stylesheet" href="css/gridGallery.css" />
  
<link href="../css/bootstrap.min.css" rel="stylesheet" media="screen">
</head>
<body>
  <!--Menu-->
	<?php include '../includes/menu.php';?>
  <!--Menu-->
    <div id="grid" data-directory="gallery"></div>

    <!-- SCRIPTS FOR FOR THE PLUGIN-->
    <script src="js/jquery-1.9.1.min.js"></script>
    <script src="js/rotate-patch.js"></script>
    <script src="js/waypoints.min.js"></script> <!-- if you wont use the Lazy Load feature erase this line -->
    <script src="js/autoGrid.min.js"></script>

    <script>
      $(function(){
            //INITIALIZE THE PLUGIN
            $('#grid').grid({
                categoriesOrder: 'byName', //byDate, byDateReverse, byName, byNameReverse, random
                imagesOrder: 'byDate', //byDate, byDateReverse, byName, byNameReverse, random
                isFitWidth: true, //Nedded to be true if you wish to center the gallery to its container
                lazyLoad: true, //If you wish to load more images when it reach the bottom of the page
                showNavBar: true, //Show the navigation bar?
                smartNavBar: true, //Hide the navigation bar when you don't have categories or just 1
                imagesToLoadStart: 15, //The number of images to load when it first loads the grid
                imagesToLoad: 5, //The number of images to load when you click the load more button
                aleatoryImagesFromCategories: true,//Get few images from each category if not it will get them in order
                horizontalSpaceBetweenThumbnails: 15, //The space between images horizontally
                verticalSpaceBetweenThumbnails: 15, //The space between images vertically
                columnWidth: 'auto', //The width of each columns, if you set it to 'auto' it will use the columns instead
                columns: 5, //The number of columns when you set columnWidth to 'auto'
                columnMinWidth: 220, //The minimum width of each columns when you set columnWidth to 'auto'
                isAnimated: true, //Animation when resizing or filtering with the nav bar
                caption: false, //Show the caption in mouse over
                captionCategory: false,//Show the category section of the caption
                captionType: 'grid', // 'grid', 'grid-fade', 'classic' the type of caption effect
                lightBox: true, //Do you want the lightbox?
                lightboxKeyboardNav: true, //Keyboard navigation of the next and prev image
                lightBoxSpeedFx: 500, //The speed of the lightbox effects
                lightBoxZoomAnim: true, //Do you want the zoom effect of the images in the lightbox?
                lightBoxText: false, //If you wish to show the text in the lightbox
                lightboxPlayBtn: true, //Show the play button?
                lightBoxAutoPlay: false, //The first time you open the lightbox it start playing the images
                lightBoxPlayInterval: 4000, //The interval in the auto play mode 
                lightBoxShowTimer: true, //If you wish to show the timer in auto play mode
                lightBoxStopPlayOnClose: false, //Stop the auto play mode when you close the lightbox?
            });
      });
    </script>

    
</body>
</html>