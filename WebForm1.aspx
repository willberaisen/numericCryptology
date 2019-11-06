<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="bootson.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Resume - Start Bootstrap Theme</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom fonts for this template -->
    <link href="https://fonts.googleapis.com/css?family=Saira+Extra+Condensed:500,700" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Muli:400,400i,800,800i" rel="stylesheet">
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="css/resume.min.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
       <nav class="navbar navbar-expand-lg navbar-dark bg-primary fixed-top" id="sideNav">
    <a class="navbar-brand js-scroll-trigger" href="#page-top">
      <span class="d-block d-lg-none">Ahmet Ünal Eren</span>
      <span class="d-none d-lg-block">
        <img class="img-fluid img-profile rounded-circle mx-auto mb-2" src="img/profile.jpg" alt="">
      </span>
    </a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link js-scroll-trigger" href="#about">About</a>
        </li>
        <li class="nav-item">
          <a class="nav-link js-scroll-trigger" href="#experience">Experience</a>
        </li>
        <li class="nav-item">
          <a class="nav-link js-scroll-trigger" href="#education">Education</a>
        </li>
        <li class="nav-item">
          <a class="nav-link js-scroll-trigger" href="#skills">Skills</a>
        </li>
        <li class="nav-item">
          <a class="nav-link js-scroll-trigger" href="#interests">Interests</a>
        </li>
          <li class="nav-item">
              <a class="nav-link js-scroll-trigger" href="#kri">kripto</a>
          </li>
       
      </ul>
    </div>
  </nav>

  <div class="container-fluid p-0">

    <section class="resume-section p-3 p-lg-5 d-flex align-items-center" id="about">
      <div class="w-100">
        <h1 class="mb-0">Ahmet Ünal
          <span class="text-primary">Eren</span>
        </h1>
        <div class="subheading mb-5">HKU ŞAHİNBEY / GAZİANTEP·
          <a href="mailto:name@hotmail.com">ahmet_anka913@hotmail.com</a>
        </div>
        <p class="lead mb-5">I'm a student of computer engineering department.I m working at the system of cyriptology. </p>
        <div class="social-icons">
          <a href="https://www.linkedin.com/in/ahmet-%C3%BCnal-eren-091376171/">
            <i class="fab fa-linkedin-in"></i>
          </a>
          <a href="https://github.com/Anka127">
            <i class="fab fa-github"></i>
          </a>
          <a href="https://twitter.com/ahmetunaleren">
            <i class="fab fa-twitter"></i>
          </a>
          <a href="https://www.facebook.com/mail.ahmet">
            <i class="fab fa-facebook-f"></i>
          </a>
        </div>
      </div>
    </section>

    <hr class="m-0">

    <section class="resume-section p-3 p-lg-5 d-flex justify-content-center" id="experience">
      <div class="w-100">
        <h2 class="mb-5">Experience</h2>

        <div class="resume-item d-flex flex-column flex-md-row justify-content-between mb-5">
          <div class="resume-content">
            <h3 class="mb-0">CODER</h3>
            <div class="subheading mb-3">Personal Working</div>
            <p>Working on python and c#</p>
          </div>
          <div class="resume-date text-md-right">
            <span class="text-primary">2019 - Present</span>
          </div>
        </div>

        

   </div>

    </section>

    <hr class="m-0">

    <section class="resume-section p-3 p-lg-5 d-flex align-items-center" id="education">
      <div class="w-100">
        <h2 class="mb-5">Education</h2>

        <div class="resume-item d-flex flex-column flex-md-row justify-content-between mb-5">
          <div class="resume-content">
            <h3 class="mb-0">University of Hasan Kalyoncu</h3>
            <div class="subheading mb-3">BACHELOR OF ENGİNEERİNG</div>
            <div>Computer Engineering - Object Oriented Programming</div>
            <p>GPA: 3.23</p>
          </div>
          <div class="resume-date text-md-right">
            <span class="text-primary">August 2018 - May 2023</span>
          </div>
        </div>

        <div class="resume-item d-flex flex-column flex-md-row justify-content-between">
          <div class="resume-content">
            <h3 class="mb-0">MGN Bayel High Scholl</h3>
            <div class="subheading mb-3">
              Anatolian High School</div>
            <p>GPA: 3.56</p>
          </div>
          <div class="resume-date text-md-right">
            <span class="text-primary">August 2014 - May 2015</span>
          </div>
        </div>

      </div>
         
    </section>

    <hr class="m-0">

    <section class="resume-section p-3 p-lg-5 d-flex align-items-center" id="skills">
      <div class="w-100">
        <h2 class="mb-5">Skills</h2>
          <img align="right" src="img/coder.jpg"/>

        <div class="subheading mb-3">Programming Languages &amp; Tools</div>
        <ul class="list-inline dev-icons">
          <li class="list-inline-item">
            <i class=""fab fa-html5></i>
          </li>
          <li class="list-inline-item">
            <i class="fab fa-css3-alt"></i>
          </li>
          <li class="list-inline-item">
            <i class="fab fa-python"></i>
          </li>
          
          <li class="list-inline-item">
            <i class="fab fa-java"></i>
          
        </ul>

        <div class="subheading mb-3">Workflow</div>
        <ul class="fa-ul mb-0">
          <li>
            <i class="fa-li fa fa-check"></i>
            Cryptology Programming</li>
          <li>
            <i class="fa-li fa fa-check"></i>
            Web Programming</li>
          <li>
            <i class="fa-li fa fa-check"></i>
            
            Database Management System</li>
          <li>
            <i class="fa-li fa fa-check"></i>
            Object Oriented Programming </li>
        </ul>
      </div>
    </section>

    <hr class="m-0">

    <section class="resume-section p-3 p-lg-5 d-flex align-items-center" id="interests">
      <div class="w-100">
        <h2 class="mb-5">Interests</h2>
        <p>Apart from being a computer engineer.I love the music so ı spend most of my time to listen and compose my new music.Slow,classical and jazz musics is my favorites and my favorite musicians and groups are Taylor Swift,Billie Eilish,Demi Lovato,Tom Rosenthal,Birdy,James Smith,Calum Scott,Ella Fitzgerald,The Ink Spots,Cem Adrian,Nightcore.Also I play the piano and guitar.Otherwise, I am a strict fallower of the technology.</p>
        
      </div>
    </section>
      <hr class="m-0">
    <section  class="resume-section p-3 p-lg-5 d-flex align-items-center" id="kri">
        <div class="w-100">
            <h2 class="mb-5">Cyripto</h2>
            <div class="subheading mb-3">THİS İS AN EXAMPLE OF MY CRİPTOLOGY PROJECTS</div>
            <center>
            <asp:TextBox ID="sifrele" runat="server" placeholder="ENTER TEXT"></asp:TextBox>
            <asp:TextBox ID="hazır" runat="server" placeholder="OUTPUT"></asp:TextBox><br/>
            <asp:Button ID="Button1" runat="server" Text="ENCRYPETİON" OnClick="Button1_OnClick" style="font-size:1.5em; color:beige;background-color:black" /><br/>
            <asp:Button ID="Button2" runat="server" Text="SOLVE" style="font-size:1.5em; color:black;background-color:beige" OnClick="Button2_OnClick" />
            </center>
        </div>
        
    </section>
    

  </div>

  <!-- Bootstrap core JavaScript -->
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

  <!-- Plugin JavaScript -->
  <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

  <!-- Custom scripts for this template -->
  <script src="js/resume.min.js"></script>

    </form>
</body>
</html>
