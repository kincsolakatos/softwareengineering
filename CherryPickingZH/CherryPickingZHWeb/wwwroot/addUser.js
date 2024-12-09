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
};