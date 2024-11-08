# AlterTestProject

Code Design Approach:-

Weapon Base - this contains all the basic weapon functionality that all weapons share inherit from this and and custom functionality as needed.
Weapons Manager- This Manages the weapon equipment and loading.

for ading future weapons just create a dervied class from weaponbase and add it to the list in weapons manager.

Visual effects design approach-
Created a dynamic base shader for using in all three elemntal vfx that we can modify and use according to needs.

simple to add more elemnts just copy and modify the existing vfx with its own properties.

Optimization-
Using shared shaders helps in reducing ram consumption and creating a base can make it easier to tackle performance bottlenecks.