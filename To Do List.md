#////// To do List //////

#	Make a tile set <- Done.
	Design a basic map <- Done.
	Do basic movement <- Done.
	Make sprites <- Halfway there
	Randomized map
		-Make a tile palette with already built in presets with your tileset
			-Starting zone must have 4 paths going out
			-A room with no left door can't have a right door room connected to it.
			-A room with no right door can't have a left door room connected to it.
			-A room with no top door can't have a bottom door room connected to it.
			-A room with no bottom door can't have a top door room connected to it.
			-Rooms can have pathways. 
				-Vertical pathway must be connected to only top doors and bottom doors.
				-Horizontal pathway must be connected to only left doors and right doors.
			-Final room must be the furthest room from the start.
				-There needs to be a clear path to the final room from the first room.
				-The final room cannot be next to the starting room.
				-A final room needs either a vertical pathway leading to it or a horizontal pathway.
				-The door rules must apply to the final room aswell.
				-The final room must contain a "Back to town", "Descend to a lower level" portal/door.
			-Alcove rooms can only be attached to pathway endings which only has a top or bottom room always.
				-Alcove rooms can only be attached to horizontal pathways.
			-A room can only be connected once to a previous room.
				-Its pathway must not hit any other room but the last one.

				// So far thats what I thought of //


#	-Make menü screen.
		-New game
		-Load game
			-3 save files
		-Options
			-Volume/Sounds
				-Effects
				-Music
				-Master
			-Resolution settings
			-Fullscreen/Windowed/Borderless Windowed
			-Control scheme (In first build cannot be changed)
		-Exit game
		
#	-Make Pause screen
		-Options
		-Exit to menü	! IF NOT SAVED PROGRESS WILL BE LOST !
		-Exit to desktop ! IF NOT SAVED PROGRESS WILL BE LOST !

#	-Implement saving feature.
		-Player can only save if interacting with specific object or at the end of the level when descending to a lower level.
		-Loading game will automatically put you back in main town.

#	-Main town features
		-Merchants
			-Gear
				-Armor pieces
			-Weapons
			-Enchanting
				-Costs XP + Gold 
			-Consumable shop
				-Food (Replenishes health over time)
				-Potions (Replenishes health/mana, gives dmg bonuses, def bonuses, resistances)
		-Level up
			-Can only be done in the main town
				-Strength
				-Stamina
				-Dexterity
				-Mana (First build will only let you use healing spells with mana.)
#So far thats all I want to get done then get the list for enemies and stuff.
