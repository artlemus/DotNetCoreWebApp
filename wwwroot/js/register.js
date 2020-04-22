function Car(
  make,
  model,
  year,
  color,
  price,
  mileage,
  mpg,
  image,
  seats,
  condition
) {
  this.make = make;
  this.model = model;
  this.year = year;
  this.color = color;
  this.price = price;
  this.mileage = mileage;
  this.mpg = mpg;
  this.image = image;
  this.seats = seats;
  this.condition = condition;
}

function registerCar() {
  // get variables
  var make = $("#txtMake").val();
  var model = $("#txtModel").val();
  var year = $("#txtYear").val();
  var color = $("#txtColor").val();
  var price = $("#txtPrice").val();
  var mileage = $("#txtMi").val();
  var mpg = $("#txtMpg").val();
  var image = $("#txtImg").val();
  var seats = $("#txtSeats").val();
  var condition = $("#selCondition").val();

  var priceNum = 0;
  if (price) {
    priceNum = parseFloat(price);
  }
  var yearNum = 0;
  if (year) {
    yearNum = parseInt(year);
  }
  var seatsNum = 0;
  if (seats) {
    seatsNum = parseInt(seats);
  }
  var mileageNum = 0;
  if (mileage) {
    mileageNum = parseInt(mileage);
  }
  var mpgNum = 0;
  if (mpg) {
    mpgNum = parseInt(mpg);
  }

  // create an object
  var car = new Car(
    make,
    model,
    yearNum,
    color,
    priceNum,
    mileageNum,
    mpgNum,
    image,
    seatsNum,
    condition
  );
    console.log(car);
    
  // send the object to ajax
    $.ajax({
        url: '/catalog/saveCar',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(car),
        success: function (res) {
            console.log("server responded", res);
        },

        error: function(detail){
            console.log("Error on request", detail);
        }
    })
    
}
function init() {
  console.log("register page");
  $("#btnSave").click(registerCar);
}

window.onload = init;
