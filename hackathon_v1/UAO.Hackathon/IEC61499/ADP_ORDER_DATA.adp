<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="ee61c2cb-3e59-46e8-97c3-7007bc410645" Name="ADP_ORDER_DATA" Comment="Adapter Interface" Namespace="UAO.Hackathon">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Flexbridge AB" Version="0.0" Author="Dmitrii" Date="12/17/2022" />
  <InterfaceList>
    <EventInputs>
      <Event Name="REQ" />
    </EventInputs>
    <EventOutputs>
      <Event Name="UPD" Comment="Confirmation from Plug">
        <With Var="SD_ID" />
        <With Var="order_data" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="SD_ID" Type="STRING[64]" Comment="Confirmation Data from Plug" />
      <VarDeclaration Name="order_data" Type="STRING[64]" Comment="Indication Data from Plug" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="UPD" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="UPD" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="UPD" Parameters="SD_ID" />
        <OutputPrimitive Interface="SOCKET" Event="UPD" Parameters="SD_ID" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="order_data" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="order_data" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>