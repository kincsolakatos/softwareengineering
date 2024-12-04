function addBook() {
    var book2 = {
        title: document.getElementById("title").value,
        author: document.getElementById("author").value,
        year: document.getElementById("year").value,
        genre: document.getElementById("genre").value,
        isAvailable: document.getElementById("isAvailable").checked
    };
    fetch("/api/books",
        {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(book2)
        }).then(x => {
            if (x.ok)
                alert("Siker");
            else
                alert("kudarc");
        });
};
function deleteBook() {
    var id = document.getElementById("id").value;
    fetch(`/api/books/${id}`,
        {
            method: 'DELETE'
        }).then(response => {
            if (response.ok)
                alert("siker");
            else
                alert("kudarc");
        });
}