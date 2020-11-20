# .Net

To Test with Postman

// Create a new tag
https://localhost:[port]/api/tags

{
	"id" : 1,
	"title": "tag1",
}

// Create a menu
https://localhost:[port]/api/Categories

{
	"id" : 1,
	"title": "menu1",
	"level": 1,
	"tagId": 1
}

// Create a submenu
{
	"id" : 2,
	"title": "subMenu1",
	"level": 2,
	"tagId": 1
}

{
	"id" : 3,
	"title": "SubMenu2",
	"level": 2,
	"tagId": 1
}

// Show All Menues
https://localhost:[port]/api/Categories

// Show Submenues for a Menu
https://localhost:[port]/api/Categories/1
