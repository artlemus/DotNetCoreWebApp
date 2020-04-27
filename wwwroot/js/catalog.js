
function retrieveCatalog() {
    // url: /catalog/getCatalog
    $.ajax({
        url: '/catalog/getCatalog',
        type: 'GET',
        success: res => {
            console.warn("server responded", res);
            // display cars on the html
            for (let i = 0; i < res.length; i++){
                displayCar(res[i]);
            }
        },

        error: detail => {
            console.error("Error on request", detail);
        }
    })
}

function displayCar(car) {
    // get container
    var container=$("#catalog");

    // create template/sintax
    var sntx = `
    <div class="card item list" style="width: 20rem;">
    <div class="row col-md-12">
  <img class="card-img-top image" src="${car.image}"
  style=" width:20em !important; height: 15em !important;" alt="Card image cap">
  <div class="card-body">
    <h5 class="card-title">${car.condition} ${car.make} ${car.model}</h5>
    <p class="card-text">
    mileage:
    ${car.mileage}
    <br>
    seats:
    ${car.seats}
    <br>
    mpg:
    ${car.mpg}
    <br>
    year:
    ${car.year}

    </p>
    <a href="#" class="btn btn-primary">Rent Car</a>
  </div>
  </div>
</div>`;




    // add template to container
    container.append(sntx);
}


function init() {
    console.log("Catalog page!")
    // get data 
    retrieveCatalog();
    // hooks events
}
window.onload = init;