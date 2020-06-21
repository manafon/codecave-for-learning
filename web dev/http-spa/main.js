// Reference from: https://javascript.christmas/2019/12

// Store all page div Reference
PAGES = {};

PAGES.main = {};
PAGES.main.page = document.querySelector("#main");

PAGES.subpage = {};
PAGES.subpage.page = document.querySelector("#subPage");
PAGES.subpage.content = document.querySelector("#subPageDiv");

PAGES.page404 = {};
PAGES.page404.page = document.querySelector("#page404");
PAGES.page404.error = document.querySelector("#page404-error");

// Function to change page content
pageFunctions = {};
pageFunctions.page404 = function() {
  PAGES.page404.error.innerHTML = `Page ${location.hash.substr(1)} not found!`;
};

pageFunctions.subPage = function() {
  PAGES.subpage.content.innerHTML("Subpage Content :) ")
};

var path;

// Function to handle page change
function navigate() {
  path = location.hash
    .substr(1)
    .toLowerCase()
    .split("/");

  // Find what page to show
  var currentPage = path[0];
  if (!PAGES.hasOwnProperty(currentPage)) {
    if (path[0] === "") {
      currentPage = "main";
    } else {
      currentPage = "page404";
    }
  }

  // Make page dicv active/ inactive
  for (var page in PAGES) {
    if (PAGES.hasOwnProperty(page)) {
      PAGES[page].page.classList.remove("active");
    }
  }

  PAGES[currentPage].page.classList.add("active");

  //Run custom page code if it exists
  if (pageFunctions.hasOwnProperty(currentPage)) {
    pageFunctions[currentPage]();
  }
}

// First time load page
navigate();

// load navigate by href
window.onhashchange = navigate;