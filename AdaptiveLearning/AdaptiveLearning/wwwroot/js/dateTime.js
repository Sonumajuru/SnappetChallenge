// JS File for DateTimePicker
// Performs a query to save the selected date which is retrieved from the controller to display
class DateTimePicker {
    
    constructor() {
        this.picker = document.querySelector(".jsDatetimePicker");
        this.picker.addEventListener("change", function(e){
            this.filterResultByDate();
        }.bind(this));
    }
    
    filterResultByDate() {
        window.location = "/learning/" + this.picker.value;
    }
}