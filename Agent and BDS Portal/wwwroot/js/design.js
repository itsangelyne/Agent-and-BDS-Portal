function showTab(tabId, selectedButton) {
    let buttons = document.querySelectorAll(".btn-group button");
    buttons.forEach(button => {
        button.classList.remove("active-tab");
        button.classList.add("inactive-tab");
    });

    selectedButton.classList.add("active-tab");
    selectedButton.classList.remove("inactive-tab");

    // Hide both tabs first
    document.getElementById("personalInfo").style.display = "none";
    document.getElementById("otherDetails").style.display = "none";

    // Show the selected tab
    document.getElementById(tabId).style.display = "block";
}