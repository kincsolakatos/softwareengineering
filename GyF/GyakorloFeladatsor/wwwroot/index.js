async function fetchBooks()
{
    const books = await (await fetch("api/index")).json();
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
document.addEventListener("DOMContentLoaded", _ => {
    document.getElementById("addButton").addEventListener("click", _ => {
        let data =
        {
            "title": document.getElementById("title").value,
            "author": document.getElementById("author").value,
            "year": parseInt(document.getElementById("year").value),
            "genre": document.getElementById("genre").value,
            "isAvailable": true
        }
        fetch("api/index",
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
            })
    });
    document.getElementById("deleteButton").addEventListener("click", _ => {
        let id = document.getElementById("deleteId").value
        fetch(`api/index/${id}`,
            {
                method: 'DELETE'
            }).then(res => {
                alert(res.ok ? "Könyv törölve!" : "Hiba történt, az ID nem található.");
                if (res.ok) {
                    document.getElementById("deleteBookForm").reset();
                    fetchBooks();
                }
            })
    });
});