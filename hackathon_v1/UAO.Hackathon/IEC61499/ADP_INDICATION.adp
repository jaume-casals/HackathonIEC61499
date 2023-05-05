<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="b92451b6-9a36-4d7c-86ec-b5926cc891c1" Name="ADP_INDICATION" Comment="Adapter Interface" Namespace="UAO.Hackathon">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Flexbridge AB" Version="0.0" Author="Dmitrii" Date="1/1/2023" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="START" Comment="Request from Socket" />
      <Event Name="STOP" Comment="Response from Socket" />
      <Event Name="ONCE" />
    </EventOutputs>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="START" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="START" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="CNFD" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="CNFD" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="INDD" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="INDD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="STOP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="STOP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>