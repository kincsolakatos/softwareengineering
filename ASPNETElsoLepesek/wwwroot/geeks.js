var viccek;
function letoltes() {
    fetch("/geeks.json")
        .then(response => response.json())
        .then(data => letoltesBefejezodott(data))
        .catch(error => console.error("Hiba tortent a letoltes soran: ", error));

}
function letoltesBefejezodott(d) {
    console.log("Sikeres letoltes");
    console.log(d);
    viccek = d;
    const viccekLista = document.getElementById("viccek-lista");
    viccek.forEach((vicc) => {
        const listItem = document.createElement("li");
        listItem.innerHTML =
            `<strong>${vicc.question}</strong><br>
            <em>${vicc.answer}</em><br>
            <small>By: ${vicc.author} (${vicc.created})</small>`;
        viccekLista.appendChild(listItem);
    });
}
window.onload = letoltes;