<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Error.aspx.cs" Inherits="Error" %>

<!DOCTYPE html>
<base href="http://www.project-euh.com/404/">
<html>
<head>
<title>404</title>
<style>
<!--
	td	{font-family: sans-serif, arial; font-size:9px}
//-->
</style>


<script language="JavaScript">
<!--



	aantalPics = 37;
	aantalTijd = 100;
	aantalAan = 0;
	func = 0;

	show = new Image();
	hide = new Image();

	show.src="404.gif";
	hide.src="../gfx/spacer.gif";

	function showpic(i){
		document.images[i].src=show.src;
		aantalAan++;
	}

	function hidepic(i){
		document.images[i].src=hide.src;
		aantalAan--;
	}

	function isShowing(i){
		return document.images[i].src.indexOf("404.gif")>=0;
		return document.images[i].src == show.src;
	}

	function change(){
		x = Math.round(aantalPics*Math.random())%aantalPics;
		if(!func){

			if(isShowing(x)){
				hidepic(x);
			}else{
				showpic(x);
			}
			if(Math.round(Math.random()*75)==25){
				func=1;
			}
		}else{

			while(isShowing(x)){
				x= (x+1)%aantalPics;
			}
			showpic(x);
			if(aantalAan == aantalPics){
				func=0;
			}
		}
		window.setTimeout("change()", Math.round(aantalTijd*Math.random()));
	}


	function init(){
		for(x=0;x<aantalPics;x++){
			showpic(x);
		}
		window.setTimeout("change()", 1000);
	}


//-->
</script>
</head>
<body bgcolor="#ffffff" onLoad="init();">
<table border=0 cellpadding=0 cellspacing=0 width="100%" height="100%">
<tr><td align="center" valign="middle">
<table border=0 cellpadding=0 cellspacing=2>
<tr>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            cannot</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            find</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            target</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            server</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            -file</td>
	<td width=31>&#160;</td>

</tr>
<tr>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            you</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            either</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            mis-</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            typed</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            the</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            url</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            or</td>
	<td width=31>&#160;</td></tr>
<tr>
	<td width=31>&#160;</td>

	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            you</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            might</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            be </td>
	<td width=31>&#160;</td>

	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>

            a</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            loser</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            any-</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            way</td>
	<td width=31>&#160;</td>
</tr>
<tr>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            you</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            have</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            no</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            right</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            being</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            here</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            please</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>

	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>

            leave</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            this</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            page</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            now</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            or</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            stay</td>
</tr>
<tr>

	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            here</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            and</td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            be </td>
	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>
            a</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>
	<td width=31>&#160;</td>

	<td width=31><a href="../random.html"><img src="404.gif" width=31 height=32 border=0></a><br>

            loser</td>
	<td width=31><OBJECT classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"
 codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=5,0,0,0"
 WIDTH=18 HEIGHT=18>
 <PARAM NAME=movie VALUE="404.swf"> <PARAM NAME=quality VALUE=high> <PARAM NAME=bgcolor VALUE=#FFFFFF> <EMBED src="404.swf" quality=high bgcolor=#FFFFFF  WIDTH=18 HEIGHT=18 TYPE="application/x-shockwave-flash" PLUGINSPAGE="http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash"></EMBED>
</OBJECT></td>

</tr>

</table>

</td></tr>
</table>
</body>
</html>