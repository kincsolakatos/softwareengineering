function LoadUsers() {
    fetch("api/index")
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
window.onload = LoadUsers;