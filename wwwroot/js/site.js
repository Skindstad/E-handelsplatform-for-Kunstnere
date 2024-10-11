// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let getSuggestions = () => [];
let onSelect = () => {};

// Get reference to search input and dropdown list
const searchInput = document.getElementById("searchInput");
const suggestionsList = document.getElementById("suggestionsList");

// Event listener for search input field
searchInput.addEventListener("input", function () {
    // Get the current input value
    const inputValue = searchInput.value.toLowerCase();

    // Clear previous suggestions
    suggestionsList.innerHTML = "";

    if (inputValue.length > 0) {
        // Filter suggestions based on input
        const filteredSuggestions = getSuggestions().filter((item) =>
            item.toLowerCase().includes(inputValue)
        );

        // Populate the dropdown with filtered suggestions
        filteredSuggestions.forEach((suggestion) => {
            const listItem = document.createElement("li");
            listItem.classList.add("dropdown-item");
            listItem.textContent = suggestion;

            // Add click event to fill the input when a suggestion is clicked
            listItem.addEventListener("click", () => {
                searchInput.value = suggestion;
                suggestionsList.innerHTML = ""; // Clear dropdown after selection
                onSelect(suggestion);
            });

            suggestionsList.appendChild(listItem);
        });

        // Show the dropdown if there are suggestions
        if (filteredSuggestions.length > 0) {
            suggestionsList.style.display = "block";
        } else {
            suggestionsList.style.display = "none";
        }
    } else {
        // Hide the dropdown if input is empty
        suggestionsList.style.display = "none";
    }
});

searchInput.addEventListener("input", () => {
    onSelect(searchInput.value);
});
