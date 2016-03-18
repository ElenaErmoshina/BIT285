<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisitorsLog.aspx.cs" Inherits="BIT285_assighment1.VisitorsLog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visitor log</title>
</head>
<style>
    li {list-style-type: none;}</style>
<script   src="https://code.jquery.com/jquery-2.2.2.min.js"   integrity="sha256-36cp2Co+/62rEAAYHLmRCPIych47CvdM+uTBJwSzWjI="   crossorigin="anonymous"></script>
<link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
 <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>

<body>
    <form id="form1" runat="server">
    <div>
    <div>
        <label for="user-list">Visitor table</label>
        <ul id="user-list">

        </ul>
    </div>
    <div id="user-details"></div>
    </div>
    </form>
    <script type="text/javascript" src="js/VisitorLog.js">
    </script>
</body>
</html>
