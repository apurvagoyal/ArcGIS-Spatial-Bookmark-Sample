Spatial Bookmark Manager

Supported .NET framework and ArcGIS Mobile version 

-.NET compact framework 2.0

-ArcGIS Mobile 9.3 SP1

-Windows Mobile 5.0 Pocket PC


Install instructions:

1) Open the AGSMobileSpatialBookmarkSample solution in Visual Studio 2008

2) Build the SpatialBookmarkManager project

3) In Visual Studio -->Go to View-->Toolbox

3) Right click in toolbox and select choose items

4) browse to Timmons.ArcGIS.Mobile.SpatialBookmarkManager.dll

5) The SpatialBookmarkManager control should display in the toolbox

6) In the ArcGISMobileSpatialBookmarkSample project, tab page 1 contains map control. In the solutions explorer expand Properties folder and open Resources.resx file and specify the path to mobile service and base layer data for the map.

7) Drag the spatialbookmarkmanager control to tab page 2 of Form1

7) set the BookmarkMap property of the spatialbookmarkmanager to the map1

8) Zoom in to the map 

9) Specify the name of the bookmark and Click Create button to create the spatial bookmark (the created book mark will be added to the list box)

10) To delete a bookmark-select a bookmark in the list and click Delete button.

11) To zoom to a bookmark-select a bookmark in the list and click Zoom To button.

12) To export a bookmark-zoom in or out of the map and then click Save button. Specify the file location. An xml file is saved at the specified location.

13) To load a bookmark-click Load button and browse to the location of the xml file as created in step 12. Map is automatically zoomed in to the loaded bookmark.
