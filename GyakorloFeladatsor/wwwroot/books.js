async function fetchBooks() {
    const books = await (await fetch("api/books")).json();
    const tableBody = document.getElementById("tb_konyvek");
    tableBody.innerHTML = books.map(book =>
        `<tr>
                <td>${book.id}</td>
                <td>${book.title}</td>
                <td>${book.author}</td>
                <td>${book.year}</td>
                <td>${book.genre}</td>
                <td>${book.isAvailable ? "Igen" : "Nem"}</td>
            </tr>`).join('');
}
window.onload = fetchBooks;
document.getElementById("addBookForm").addEventListener("submit", (e) => {
    e.preventDefault();
    const data =
    {
        title: document.getElementById("title").value,
        author: document.getElementById("author").value,
        year: parseInt(document.getElementById("year").value),
        genre: document.getElementById("genre").value,
        isAvailable: true
    };
    fetch("api/books",
        {
            method: 'POST',
            headers:
            {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(data)
        }).then(res => {
            alert(res.ok ? "Siker" : "Kudarc");
            if (res.ok) {
                document.getElementById("addBookForm").reset();
                fetchBooks();
            }
        });
});
document.getElementById("deleteBookForm").addEventListener("submit", (e) => {
    e.preventDefault();
    const id = document.getElementById("deleteId").value;
    fetch(`api/books/${id}`,
        {
            method: 'DELETE'
        }).then(res => {
            alert(res.ok ? "Könyv törölve!" : "Hiba történt, az ID nem található.");
            if (res.ok) document.getElementById("deleteBookForm").reset();
        });
});