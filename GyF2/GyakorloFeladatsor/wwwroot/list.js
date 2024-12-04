function booksLoad() {
    fetch("/api/books")
        .then(response => response.json())
        .then(books => {
            var list = document.getElementById("listTbody");
            list.innerHTML = "";
            books.forEach(book => {
                var row =
                    `<tr>
                        <td>${book.id}</td>
                        <td>${book.title}</td>
                        <td>${book.author}</td>
                        <td>${book.year}</td>
                        <td>${book.genre}</td>
                        <td>${book.isAvailable}</td>
                    </tr>`;
                list.innerHTML += row;
            });
        });
}
window.onload = booksLoad;
