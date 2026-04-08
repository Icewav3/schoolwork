Hey Dylan, to briefly cover what we discussed in class wednesday, I was to create a todolist/plan for what I need to do to get the room logging feature you had suggested implemented. We would then use that as the submission for Game development 2 - Assignment 3 (The iteration assignment). Here is my current todo and plan.

### Todo:

- [ ] Component refactor (nearly done)
- [ ] Resolve issue with subscribing to cates damage system (WIP)

#### Cleaning
- [x] Remove unused now redudant blueprint library functions that will be taken over by the new component.

#### JSON schema issues:

###### Replace in dataset
- [ ] "death" --> "respawn"
- [ ] "framecount" --> "event_order"
###### Additions
- [ ] "room_name"
#### Marimo Visualization issues:
###### Debugging tools
- [x] duplicated event count
###### Replacements
- [ ] change framecount to event_order

#### Features:
- [ ] Room logging
    - [ ] Test locally
    - [ ] Update JSON schema
    - [ ] Figure out how to setup automatic metadata generation
- [ ] PIE (play in editor) awareness
    - [ ] Test locally
    - [ ] Update JSON schema
