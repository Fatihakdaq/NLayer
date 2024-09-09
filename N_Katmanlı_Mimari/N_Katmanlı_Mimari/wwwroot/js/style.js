// Product

let productIdToDelete;

function setDeleteProductId(productId) {
    productIdToDelete = productId;
}

function deleteProduct() {
    fetch(`/Product/Delete?id=${productIdToDelete}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => {
            if (response.ok) {
                location.reload();
            } else {
                console.error("There was an error with the delete request.");
            }
        })
        .catch(error => {
            console.error("There was an error with the delete request:", error);
        });
}

// Reservation

let reservationIdToDelete;

function setDeleteReservationId(reservationId) {
    reservationIdToDelete = reservationId;
}

function deleteReservation() {
    fetch(`/Reservation/Delete?id=${reservationIdToDelete}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => {
            if (response.ok) {
                location.reload();
            } else {
                console.error("There was an error with the delete request.");
            }
        })
        .catch(error => {
            console.error("There was an error with the delete request:", error);
        });
}

// User

let userIdToDelete;

function setDeleteUserId(userId) {
    userIdToDelete = userId;
}

function deleteUser() {
    fetch(`/User/Delete?id=${userIdToDelete}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ UserId: userIdToDelete })
    })
        .then(response => {
            if (response.ok) {
                location.reload();
            } else {
                console.error("There was an error with the delete request.");
            }
        })
        .catch(error => {
            console.error("There was an error with the delete request:", error);
        });
}
