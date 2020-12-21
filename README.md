<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/ISaneI/sendToThings3">
    <img src="sendToThings3/Resources/logo.ico" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">sendToThings3</h3>

  <p align="center">
    A tiny Windows Tool that sends tasks over mail to Things 3
    <br />
    <a href="https://github.com/ISaneI/sendToThings3"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/ISaneI/sendToThings3/issues">Report Bug</a>
    ·
    <a href="https://github.com/ISaneI/sendToThings3/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary><h2 style="display: inline-block">Table of Contents</h2></summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <ul>
        <li><a href="#settings">Settings</a></li>
      </ul>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

When I went back to use Things3 on IOS and Mac I realized there is no *cool* way to send Tasks from my Windows Desktop. Opening the mails and sending tasks there is a lot of effort.

I wanted to quickly add Task to my Inbox. So here it is.
Currently its not beautiful but it does its job. 

![NewTask](/images/newTask.png) ![Taskbar](/images/taskbar.png) 

<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

* Microsoft .NET Framework 4.7.2
  * Should already be installed by Windows Updates. If not here is a download link [Net 4.7.2](https://support.microsoft.com/de-de/help/4054531/microsoft-net-framework-4-7-2-web-installer-for-windows)

### Installation


Download the latest sendToThings_setup.zip under [Releases](https://github.com/ISaneI/sendToThings3/releases) and install it.

You can also download the sendToThings_executable.zip under [Releases](https://github.com/ISaneI/sendToThings3/releases) and copy both files somewhere you like.

<!-- USAGE EXAMPLES -->
## Usage

1. Start the application *and/or* place it in the autostart.
1. Follow the <a href="#settings">Settings</a> steps below when using the application for the first time

### Settings

Right click the *Taskbar Icon* and open the **Settings**
  1. Enter your **Things3 personal mail** (you can find it in the Thing3 app under *Settings->ThingsCloud*)
  1. Enter credentails for a **SMTP Server** to send the mail

![Settings](/images/settings.png)

#### SMTP Server (Google)
Currently Im using a Google Mail for the SMTP server, to use this you need to [enable lesssecureapps](https://myaccount.google.com/lesssecureapps) in the Google settings

SMTP Server & Port: `smtp.gmail.com` `587`


### Keyboard Shortcuts
Function | Shortcut
------------ | -------------
**Open** the popup | `ctrl` + `alt` + `.`
**Add** details to task | `tab`
**Save/Send** task | `ctrl` + `enter` or `ctrl` + `s`


<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/github_username/repo_name/issues) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/github_username/repo.svg?style=for-the-badge
[contributors-url]: https://github.com/github_username/repo/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/github_username/repo.svg?style=for-the-badge
[forks-url]: https://github.com/github_username/repo/network/members
[stars-shield]: https://img.shields.io/github/stars/github_username/repo.svg?style=for-the-badge
[stars-url]: https://github.com/github_username/repo/stargazers
[issues-shield]: https://img.shields.io/github/issues/github_username/repo.svg?style=for-the-badge
[issues-url]: https://github.com/github_username/repo/issues
[license-shield]: https://img.shields.io/github/license/github_username/repo.svg?style=for-the-badge
[license-url]: https://github.com/github_username/repo/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/github_username
