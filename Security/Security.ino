#include <ESP8266WiFi.h>
#include <ESP8266WebServer.h>
#include <ESP8266WiFiMulti.h>
ESP8266WiFiMulti WiFiMulti;
String SSID = ""; 
String Password = "";
String DeviceId = "";
String AuthToken = "";
ESP8266WebServer server(80);
const char* MAIN_page = R"=====(
<!DOCTYPE html>
<html>
<body>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<form class="filterForm" >
<input type="text" name="SSID" />
<input type="text" name="Password" />
    <input type="submit" value="Submit" />
</form>
<script>
$('.filterForm').on('submit',function(e){
  e.preventDefault();
  var formData=$(this).serialize();
  var fullUrl = window.location.href;
  var finalUrl = fullUrl+"SubmitWifi"+"?"+formData;
  window.location.href = finalUrl;

});
</script>
 
</body>
</html>
)=====";

void handle_index() {
  //Print Hello at opening homepage

  server.send(200, "text/html", MAIN_page);
}
void SubmitWifi() { //Handler
String message = "Number of args received:";
SSID = server.arg(0);
Password = server.arg(1);
message+=SSID+" " +Password;
  const char * cP = Password.c_str();
  const char * cS = SSID.c_str();
  WiFiMulti.addAP(cP, cS);
server.send(200, "text/plain", message);    
} 

void SubmitClientSetting() { //Handler
String message = "Number of args received:";

server.send(200, "text/plain", message);    
} 

void setup()
{
    Serial.begin(115200);
    Serial.println();
    WiFi.mode(WIFI_AP_STA);
    Serial.print("Setting soft-AP ... ");
    boolean result = WiFi.softAP("ESPsoftAP_01", "12345678");
    if (result == true)
    {
        Serial.println("Ready");
        server.on("/", handle_index);
        server.on("/SubmitWifi", SubmitWifi);
          server.on("/SubmitClientSetting", SubmitClientSetting);
        server.begin(); 
    
    }
    else
    {
        Serial.println("Failed!");
    }
    
}

void loop()
{
 if ((WiFiMulti.run() == WL_CONNECTED))
 {
  if(AuthToken==""&&DeviceId=="")
  {
    server.handleClient(); 
    }
    else
    {
      
      }
  }
  else
  {
      server.handleClient(); 
  }    


    //Serial.printf("Stations connected = %d\n", WiFi.softAPgetStationNum());

}
