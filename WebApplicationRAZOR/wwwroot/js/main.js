
var currentPage = 1;
var totalPages = 2; // chọn tổng số trang tùy ý

function showPages() {
  var pages = "";
  for (var i = 1; i <= totalPages; i++) {
    if (i == currentPage) {
      pages += '<a href="#" class="active">' + i + "</a>";
    } else {
      pages += '<a href="#">' + i + "</a>";
    }
  }
  document.getElementById("pages").innerHTML = pages;
}

showPages();

document.getElementById("first").onclick = function () {
  currentPage = 1;
  showPages();
  return false;
};

document.getElementById("last").onclick = function () {
  currentPage = totalPages;
  showPages();
  return false;
};

document.getElementById("prev").onclick = function () {
  if (currentPage > 1) {
    currentPage--;
    showPages();
  }
  return false;
};

document.getElementById("next").onclick = function () {
  if (currentPage < totalPages) {
    currentPage++;
    showPages();
  }
  return false;
};