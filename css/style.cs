/*--------------------------------------------------------------------- File Name: style.css ---------------------------------------------------------------------*/


/*--------------------------------------------------------------------- import Fonts --------------------------------------------------------------------*/

@import url('https://fonts.googleapis.com/css?family=Rajdhani:300,400,500,600,700');
@import url('https://fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i');
@font-face {
    font-family: "Righteous";
    src: url("../fonts/BalooChettan-Regular.ttf");
    src: url("../fonts/BalooChettan-Regular.ttf");
}


/*****---------------------------------------- 1) font-family: 'Rajdhani', sans-serif;
 2) font-family: 'Poppins', sans-serif;
 ----------------------------------------*****/


/*--------------------------------------------------------------------- import Files ---------------------------------------------------------------------*/

@import url(animate.min.css);
@import url(normalize.css);
@import url(icomoon.css);
@import url(css/font-awesome.min.css);
@import url(meanmenu.css);
@import url(owl.carousel.min.css);
@import url(swiper.min.css);
@import url(slick.css);
@import url(jquery.fancybox.min.css);
@import url(jquery-ui.css);
@import url(nice-select.css);

/*--------------------------------------------------------------------- skeleton ---------------------------------------------------------------------*/

* {
    box-sizing: border-box !important;
    transition: ease all 0.5s;
}

html {
    scroll-behavior: smooth;
}

body {
    color: #666666;
    font-size: 14px;
    font-family: Poppins;
    line-height: 1.80857;
    font-weight: normal;
    overflow-x: hidden;
}

a {
    color: #1f1f1f;
    text-decoration: none !important;
    outline: none !important;
    -webkit-transition: all .3s ease-in-out;
    -moz-transition: all .3s ease-in-out;
    -ms-transition: all .3s ease-in-out;
    -o-transition: all .3s ease-in-out;
    transition: all .3s ease-in-out;
}

h1,
h2,
h3,
h4,
h5,
h6 {
    letter-spacing: 0;
    font-weight: normal;
    position: relative;
    padding: 0 0 10px 0;
    font-weight: normal;
    line-height: normal;
    color: #111111;
    margin: 0
}

h1 {
    font-size: 24px
}

h2 {
    font-size: 22px
}

h3 {
    font-size: 18px
}

h4 {
    font-size: 16px
}

h5 {
    font-size: 14px
}

h6 {
    font-size: 13px
}

*,
*::after,
*::before {
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

h1 a,
h2 a,
h3 a,
h4 a,
h5 a,
h6 a {
    color: #212121;
    text-decoration: none!important;
    opacity: 1
}

button:focus {
    outline: none;
}

ul,
li,
ol {
    margin: 0px;
    padding: 0px;
    list-style: none;
}

p {
    margin: 20px;
    font-weight: 300;
    font-size: 15px;
    line-height: 24px;
}

a {
    color: #222222;
    text-decoration: none;
    outline: none !important;
}

a,
.btn {
    text-decoration: none !important;
    outline: none !important;
    -webkit-transition: all .3s ease-in-out;
    -moz-transition: all .3s ease-in-out;
    -ms-transition: all .3s ease-in-out;
    -o-transition: all .3s ease-in-out;
    transition: all .3s ease-in-out;
}

img {
    max-width: 100%;
    height: auto;
}

 :focus {
    outline: 0;
}

.paddind_bottom_0 {
    padding-bottom: 0 !important;
}

.btn-custom {
    margin-top: 20px;
    background-color: transparent !important;
    border: 2px solid #ddd;
    padding: 12px 40px;
    font-size: 16px;
}

.lead {
    font-size: 18px;
    line-height: 30px;
    color: #767676;
    margin: 0;
    padding: 0;
}

.form-control:focus {
    border-color: #ffffff !important;
    box-shadow: 0 0 0 .2rem rgba(255, 255, 255, .25);
}

.navbar-form input {
    border: none !important;
}

.badge {
    font-weight: 500;
}

blockquote {
    margin: 20px 0 20px;
    padding: 30px;
}

button {
    border: 0;
    margin: 0;
    padding: 0;
    cursor: pointer;
}

.full {
    float: left;
    width: 100%;
}

.layout_padding {
    padding-top: 90px;
    padding-bottom: 0px;
}

.padding_0 {
    padding: 0px;
}


/* header section start */

.header_section {
    width: 100%;
    float: left;
    background-image: url(../images/banner-bg.png);
    height: auto;
    background-size: 100%;
    background-repeat: no-repeat;
}

.bg-light {
    background-color: #700101!important;
}

.navbar {
    padding: .5rem 0px;
    border-top: 20px solid #efe4d1;
    border-bottom: 20px solid #efe4d1;
}

.image_1 {
    width: 100%;
    float: left;
    position: relative;
    bottom: 30px;
}

.logo {
    width: 70%;
    float: left;
}

.search_icon {
    float: left;
}

.search_icon ul {
    margin: 0px;
    padding: 0px;
}

.search_icon li {
    float: left;
    padding-left: 30px;
}

.navbar-expand-lg .navbar-nav .nav-link {
    padding-right: 15px;
    padding-left: 15px;
    color: #fcfefe;
    font-size: 18px;
    text-transform: uppercase;
}

.navbar-light .navbar-nav .nav-link:focus,
.navbar-light .navbar-nav .nav-link:hover {
    color: #efe4d1;
}


/* header section end */


/* banner section start */

.banner_section {
    width: 100%;
    float: left;
    padding-bottom: 90px;
    background-color: #ffffff;
    height: auto;
    box-shadow: 0px 2px 10px 0px;
}

.banner_taital {
    width: 100%;
    float: left;
    font-size: 50px;
    color: #7c2c0c;
    font-weight: bold;
    line-height: 60px;
}

.banner_text {
    width: 80%;
    float: left;
    font-size: 16px;
    color: #7c2c0c;
    margin: 0px;
    padding-top: 30px;
    font-weight: 500;
}

.btn_main {
    width: 100%;
    float: left;
    padding-top: 50px;
}

.contact_bt {
    width: 170px;
    float: left;
}

.contact_bt a {
    width: 100%;
    float: left;
    font-size: 18px;
    color: #7c2c0c;
    background-color: transparent;
    border: 1px solid #b48569;
    padding: 8px 5px;
    text-align: center;
    font-weight: 500;
}

.contact_bt a:hover {
    color: #ffffff;
    background-color: #7c2c0c;
}

#main_slider a.carousel-control-next {
    position: absolute;
    right: 615px;
    top: 90%;
}

#main_slider a.carousel-control-prev {
    position: absolute;
    left: 615px;
    top: 90%;
}

#main_slider .carousel-control-prev,
#main_slider .carousel-control-next {
    width: 55px;
    height: 55px;
    background: transparent;
    opacity: 1;
    font-size: 20px;
    color: #7c2c0c;
    border: 1px solid #757068;
    border-radius: 100px;
}

#main_slider .carousel-control-prev:hover,
#main_slider .carousel-control-next:hover,
#main_slider .carousel-control-prev:focus,
#main_slider .carousel-control-next:focus {
    color: #000;
}


/* banner section end */


/* about section start */

.about_section {
    width: 100%;
    float: left;
}

.about_taital {
    width: 100%;
    float: left;
    font-size: 30px;
    color: #7c2c0c;
    font-weight: bold;
    padding-top: 150px;
}

.about_text {
    width: 100%;
    float: left;
    font-size: 25px;
    color: #000000;
    margin: 0px;
}

.about_section_2 {
    width: 100%;
    float: left;
    padding-top: 60px;
    padding-bottom: 60px;
}

.image_2 {
    width: 60%;
    float: left;
    border: 1px solid #7c2c0c;
    padding: 40px;
    margin: 30px 0px 0px 115px;
}

.image_2::after {
    content: '';
    position: absolute;
    width: 100px;
    height: 100px;
    background-image: url(../images/arrow-1.png);
    left: 100px;
    right: initial;
    top: 0px;
}

.image_2::before {
    content: '';
    position: absolute;
    width: 100px;
    height: 100px;
    background-image: url(../images/arrow-1.png);
    left: initial;
    right: 0px;
    bottom: 0px;
}

.readmore_bt {
    width: 170px;
    float: left;
    margin-top: 30px;
}

.readmore_bt a {
    width: 100%;
    float: left;
    font-size: 18px;
    color: #7c2c0c;
    background-color: transparent;
    border: 1px solid #b48569;
    padding: 8px 5px;
    text-align: center;
    font-weight: 500;
}

.readmore_bt a:hover {
    color: #ffffff;
    background-color: #7c2c0c;
}


/* about section end */


/* design section start */

.design_section {
    width: 100%;
    float: left;
    background-image: url(../images/blog-bg.png);
    height: auto;
    background-size: cover;
    background-repeat: no-repeat;
    padding-bottom: 100px;
}

.design_taital {
    width: 100%;
    float: left;
    font-size: 40px;
    color: #7c2c0c;
    text-align: center;
    font-weight: bold;
}

.design_text {
    width: 100%;
    float: left;
    font-size: 16px;
    color: #535353;
    text-align: center;
    margin: 0px;
}

.design_section_2 {
    width: 100%;
    float: left;
    padding-top: 50px;
}

.box_main {
    width: 100%;
    border: 1px solid #aa7662;
    padding: 50px;
}

.box_main:hover {
    background-color: #efe4d1;
    border: transparent;
}

.chair_text {
    width: 100%;
    font-size: 18px;
    color: #7c2c0c;
    text-align: center;
    margin: 0px;
    font-weight: 500;
}

.image_3 {
    width: 100%;
    text-align: center;
    padding-top: 30px;
    padding-bottom: 30px;
}

.image_4 {
    width: 100%;
    text-align: center;
    padding-top: 120px;
    min-height: 332px;
}

.buy_bt {
    width: 170px;
    margin: 0 auto;
    text-align: center;
    padding-top: 30px;
}

.buy_bt a {
    width: 100%;
    font-size: 18px;
    color: #ffffff;
    background-color: #7c2c0c;
    padding: 8px 25px;
    text-align: center;
    text-transform: uppercase;
    margin-top: 40px;
    border-radius: 5px;
}

.buy_bt a:hover {
    color: #ffffff;
    background-color: #7c2c0c;
}

#my_slider a.carousel-control-next {
    position: absolute;
    right: 615px;
    top: 110%;
    background-color: #7c2c0c;
    color: #ffffff;
}

#my_slider a.carousel-control-prev {
    position: absolute;
    left: 615px;
    top: 110%;
}

#my_slider .carousel-control-prev,
#my_slider .carousel-control-next {
    width: 55px;
    height: 55px;
    background: #ffffff;
    opacity: 1;
    font-size: 20px;
    color: #000;
    border-radius: 100px;
}

#my_slider .carousel-control-prev:hover,
#my_slider .carousel-control-next:hover,
#my_slider .carousel-control-prev:focus,
#my_slider .carousel-control-next:focus {
    color: #ffffff;
    background-color: #7c2c0c;
}

.read_bt {
    width: 170px;
    margin: 0 auto;
    padding-top: 150px;
}

.read_bt a {
    width: 100%;
    float: left;
    font-size: 18px;
    color: #7c2c0c;
    background-color: transparent;
    border: 1px solid #bb9180;
    padding: 8px 25px;
    text-align: center;
    margin-top: 40px;
}

.read_bt a:hover {
    color: #ffffff;
    background-color: #7c2c0c;
}


/* design section end */


/* newsletter section start */

.newsletter_section {
    width: 100%;
    float: left;
    background-color: #fdebcb;
    height: auto;
    padding: 90px 0px;
}

.imgage_6 {
    width: 100%;
    float: left;
}

.newsletter_taital {
    width: 100%;
    float: left;
    font-size: 40px;
    color: #7c2c0c;
    font-weight: bold;
}

.email_text {
    width: 100%;
    float: left;
    background-color: transparent;
    border: 1px solid #8b4222;
    padding: 8px 15px;
    color: #7c2c0c;
    font-size: 20px;
    margin-top: 30px;
}

input.email_text::placeholder {
    color: #7c2c0c;
}

.subscribe_bt {
    width: 260px;
    margin: 0 auto;
    text-align: center;
}

.subscribe_bt a {
    width: 100%;
    float: left;
    font-size: 16px;
    color: #ffffff;
    background-color: #7c2c0c;
    text-align: center;
    padding: 5px 20px;
    text-transform: uppercase;
    margin-top: 30px;
    border: 1px solid #7c2c0c;
}

.subscribe_bt a:hover {
    color: #7c2c0c;
    background-color: transparent;
}


/* newsletter section ens */


/* contact section start */

.contact_section {
    width: 100%;
    float: left;
    padding-bottom: 90px;
}

.contact_taital {
    width: 100%;
    float: left;
    font-size: 40px;
    color: #7c2c0c;
    font-weight: bold;
}

.contact_section_2 {
    width: 100%;
    float: left;
}

.mail_section_1 {
    width: 100%;
    margin: 0 auto;
}

.mail_text {
    width: 100%;
    float: left;
    font-size: 16px;
    color: #4f4e4e;
    border: 1px solid #8e8e8e;
    background-color: #ffff;
    padding: 15px;
    margin-top: 20px;
    border-radius: 5px;
}

.massage-bt {
    color: #4f4e4e;
    width: 100%;
    height: 110px;
    font-size: 18px;
    background-color: #ffff;
    padding: 40px 15px 0px 15px;
    border: 1px solid #8e8e8e;
    height: 110px;
    margin-top: 20px;
    border-radius: 10px;
}

.send_bt {
    width: 170px;
    margin: 0 auto;
    text-align: center;
}

.send_bt a {
    width: 100%;
    float: left;
    background-color: #7c2c0c;
    color: #ffffff;
    text-align: center;
    padding: 10px 0px;
    font-size: 16px;
    margin-top: 40px;
    border: 1px solid #7c2c0c;
    font-weight: 500;
}

.send_bt a:hover {
    background-color: transparent;
    color: #7c2c0c;
}

.map_main {
    width: 100%;
    float: left;
    padding-top: 80px;
}


/* contact section end */


/* footer section start */

.footer_section {
    width: 100%;
    float: left;
    background-color: #100703;
    height: auto;
    padding: 90px 0px;
}

.footer_location_text {
    width: 100%;
}

.footer_location_text ul {
    margin: 0px;
    padding: 0px;
    display: inline-block;
    text-align: center;
}

.footer_location_text li {
    float: left;
    font-size: 16px;
    color: #ffffff;
    padding: 50px 80px;
}

.footer_location_text li a {
    color: #ffffff;
}

.footer_location_text li a:hover {
    color: #7c2c0c;
}

.padding_left_10 {
    padding-left: 15px;
}

@import url('//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css');
#social {
    margin: 20px 0px;
}

.smGlobalBtn {
    /* global button class */
    display: inline-block;
    position: relative;
    cursor: pointer;
    width: 50px;
    height: 50px;
    padding: 0px;
    text-decoration: none;
    text-align: center;
    color: #fff;
    font-size: 25px;
    font-weight: normal;
    line-height: 2em;
    border-radius: 27px;
    -moz-border-radius: 27px;
    -webkit-border-radius: 27px;
}


/* facebook button class*/

.facebookBtn {
    background: #171717;
}

.facebookBtn:before {
    /* use :before to add the relevant icons */
    font-family: "FontAwesome";
    content: "\f09a";
    /* add facebook icon */
}

.facebookBtn:hover {
    color: #fff;
    background: #7c2c0c;
}

a.facebookBtn.smGlobalBtn.active {
    background: #7c2c0c;
}


/* twitter button class*/

.twitterBtn {
    background: #171717;
}

.twitterBtn:before {
    font-family: "FontAwesome";
    content: "\f099";
    /* add twitter icon */
}

.twitterBtn:hover {
    color: #fff;
    background: #7c2c0c;
}


/* google plus button class*/

.googleplusBtn {
    background: #171717;
}

.googleplusBtn:before {
    font-family: "FontAwesome";
    content: "\f0d5";
    /* add googleplus icon */
}

.googleplusBtn:hover {
    color: #fff;
    background: #7c2c0c;
}


/* linkedin button class*/

.linkedinBtn {
    background: #171717;
}

.linkedinBtn:before {
    font-family: "FontAwesome";
    content: "\f0e1";
    /* add linkedin icon */
}

.linkedinBtn:hover {
    color: #fff;
    background: #7c2c0c;
}

.useful_text {
    width: 100%;
    font-size: 24px;
    color: #fcfcfc;
    margin-bottom: 15px;
    font-weight: bold;
    text-transform: uppercase;
}

.lorem_text {
    width: 56%;
    float: left;
    font-size: 16px;
    color: #878585;
    margin: 0px;
    padding-top: 10px;
}

.footer_location_text li{
    font-size: 25px;
}
.footer_text {
    width: 100%;
    float: left;
    font-size: 30px;
    color: #878585;
    margin: 0px;
    padding-top: 10px;
}

.footer_menu {
    width: 100%;
    float: left;
}

.footer_menu ul {
    margin: 0px;
    padding: 0px;
}

.footer_menu li {
    padding-top: 5px;
    font-size: 16px;
    color: #878585;
}

.footer_menu li a {
    color: #878585;
}

.footer_menu li a:hover {
    color: #7c2c0c;
}


/* footer section end */


/* copright section start */

.copyright_section {
    width: 100%;
    float: left;
    background-color: #ffffff;
    height: 50px;
    position: relative;
    top: 100px;
}

.copyright_text {
    width: 100%;
    float: left;
    font-size: 16px;
    color: #0b0b0c;
    text-align: center;
    margin-left: 0px;
    font-weight: 500;
}

.copyright_text a {
    color: #0b0b0c;
}

.copyright_text a:hover {
    color: #7c2c0c;
}


/* copyright section end */

.Products h1{
    font-size: 30px;
    text-align: center;
    padding: 50px;
    position: relative;
    top: 50px;
    font-weight: bold;
}

div.gallery {
    border: 1px solid #ccc;
    
  }
  
  div.gallery:hover {
    border: 1px solid #777;
  }
  
  div.gallery img {
    width: 100%;
    height: auto;
  }
  
  div.desc {
    padding: 15px;
    text-align: center;
    font-weight: bold;
  }
  
  
  
  .responsive {
    padding: 0 6px;
    float: left;
    width: 24.99999%;
  }
  
  @media only screen and (max-width: 700px) {
    .responsive {
      width: 49.99999%;
      margin: 6px 0;
      padding: 20px;
    }
  }
  
  @media only screen and (max-width: 500px) {
    .responsive {
      width: 100%;
      padding: 20px;
    }
  }
  
  .clearfix:after {
    content: "";
    display: table;
    clear: both;
  }

