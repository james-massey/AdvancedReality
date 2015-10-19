import bpy
import mathutils

sphere = bpy.data.objects["Sphere"]
loc = (sphere.location.x, sphere.location.y, sphere.location.z)
    
    
class SphereTrackCoordinates(bpy.types.Panel):
    """A Custom Panel in the Viewport Toolbar"""
    bl_label = "SphereTrackCoordinates"
    bl_space_type = 'VIEW_3D'
    bl_region_type = 'TOOLS'
    

    def draw(self, context):
        layout = self.layout

        row = layout.row()
        row.label(text="Sphere Coordinates")
        
        row = layout.row()
        row.label(text="X-Coordinate")
        row = layout.row()
        row.label(str(loc[0]))
        
        row = layout.row()
        row.label(text="Y-Coordinate")
        row = layout.row()
        row.label(str(loc[1]))
        
        row = layout.row()
        row.label(text="Z-Coordinate")
        row = layout.row()
        row.label(str(loc[2]))

        split = layout.split()
        col = split.column(align=True)
        
        #col.operator("mesh.primitive_plane_add", text="Plane", icon='MESH_PLANE')
        #col.operator("mesh.primitive_torus_add", text="Torus", icon='MESH_TORUS')


def register():
    bpy.utils.register_class(SphereTrackCoordinates)

def unregister():
    bpy.utils.unregister_class(SphereTrackCoordinates)

if __name__ == "__main__":
   register()