
    //document.getElementById('btnSignout').addEventListener('click', function () {
    //    fetch('/api/AccountStaff/signout', {
    //        method: 'POST',
    //        //headers: {
    //        //    'Authorization': 'Bearer ' + yourAccessToken // Replace with the actual JWT token
    //        //}
    //    })
    //        .then(response => response.json())
    //        .then(data => {
    //            // Handle successful signout (e.g., redirect to login page)
    //            window.location.href = '/admin'; // Replace with your login page URL
    //        })
    //        .catch(error => {
    //            console.error('Error signing out:', error);
    //        });
    //});
function getCookie(name) {
    const value = `; ${document.cookie}`;
    const parts = value.split(`; ${name}=`);
    if (parts.length === 2) return parts.pop().split(';').shift();
}

const token = getCookie('token');
document.addEventListener('DOMContentLoaded', function () {
        var btnSignout = document.getElementById('btnSignout');
        if (btnSignout) {
            btnSignout.addEventListener('click', function () {

                fetch('/api/AccountStaff/signout', {
                    method: 'POST',
                    headers: {
                        'Authorization': 'Bearer ' + token
                    }
                })
                    .then(data => {
             
                    // Handle successful signout (e.g., redirect to login page)
                        window.location.href = '/admin'; // Replace with your login page URL
                       
                })
                .catch(error => {
                    console.error('Error signing out:', error);
                });
            });
        }
    });