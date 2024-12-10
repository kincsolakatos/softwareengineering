function LoadUsers() {
    fetch("/api/users")
        .then(response => response.json())
        .then(users => {
            var list = document.getElementById("tbodyUsers");
            list.innerHTML = "";
            users.forEach(user => {
                var row =
                    `<tr>
                        <td>${user.userId}</td>
                        <td>${user.userName}</td>
                        <td>${user.email}</td>
                        <td>${user.registrationDate}</td>
                    </tr>`;
                list.innerHTML += row;
            });
        });
}
function addUser() {
    var user = {
        userName: document.getElementById("userName").value,
        email: document.getElementById("email").value,
        registrationDate: document.getElementById("registrationDate").value
    };
    fetch("/api/users",
        {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        }).then(u => {
            if (u.ok)
                alert("Siker");
            else
                alert("kudarc");
        });
    LoadUsers;
};
window.onload = LoadUsers;
