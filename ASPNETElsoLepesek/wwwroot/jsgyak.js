const faktorialis = (n) =>
{
    if (n === 0 || n === 1)
        return 1;
    return n * faktorialis(n - 1);
};
const binomialisEgyutthato = (n, k) =>
{
    return faktorialis(n) / (faktorialis(k) * faktorialis(n - k));
};
window.onload = () =>
{
    const pascalContainer = document.getElementById("pascal");
    for (let sor = 0; sor < 10; sor++)
    {
        const sorDiv = document.createElement("div");
        sorDiv.classList.add("sor");
        for (let oszlop = 0; oszlop <= sor; oszlop++)
        {
            const elemDiv = document.createElement("div");
            elemDiv.classList.add("elem");
            const value = binomialisEgyutthato(sor, oszlop);
            elemDiv.innerText = value;
            const szin = 255 - Math.min(value * 2, 255) - 4;
            elemDiv.style.backgroundColor = `rgb(255, ${szin}, ${szin})`;
            sorDiv.appendChild(elemDiv);
        }
        pascalContainer.appendChild(sorDiv);
    }
};