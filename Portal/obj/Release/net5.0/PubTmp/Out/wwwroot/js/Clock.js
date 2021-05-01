const hour = document.querySelector("#hour");
const minute = document.querySelector("#minute");
const second = document.querySelector("#second");

//
window.addEventListener("load", () => {
    setInterval(() => {
        let dt = new Date();
        $("#hourVal").html(dt.getHours());
        $("#minuteVal").html(dt.getMinutes());
        if (dt.getSeconds() < 10) {
            $("#secondVal").html(`0${dt.getSeconds()}`);
        } else {
            $("#secondVal").html(`${dt.getSeconds()}`);
        };
        $("#halfVal").html(dt.getHours() < 12 ? "AM" : "PM");
        //
        let h_deg = (360 / 12) * dt.getHours();
        hour.style.transform = `rotate(${h_deg}deg)`;
        let m_deg = (360 / 60) * dt.getMinutes();
        minute.style.transform = `rotate(${m_deg}deg)`;
        let s_deg = (360 / 60) * dt.getSeconds();
        second.style.transform = `rotate(${s_deg}deg)`;
    }, 1000);
});
