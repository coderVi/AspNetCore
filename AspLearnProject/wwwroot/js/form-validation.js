document.getElementById("submitBtn").addEventListener("click", function (event)
{
    const sifre1 = document.getElementById("Pass1").value;
    const sifre2 = document.getElementById("Pass2").value;
    if (sifre1 !== sifre2) {
        event.preventDefault();
        alert("Passwords do not match.");
    }
});