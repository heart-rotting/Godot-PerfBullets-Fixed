shader_type canvas_item;

//seperates the texture into frames, this is automatically done, please do not input anythnig for these
uniform float col; //float for performance sake, never input a float here, only ints
uniform float row;

varying vec4 custom; //visiblity, offsetx, offsety

void vertex() {
	custom = INSTANCE_CUSTOM;
}

void fragment() {
    if (custom.r == 1.0) {
        vec2 cell_size = vec2(1.0 / col, 1.0 / row);

        // custom.g = column index of the frame (horizontal → x)
        // custom.b = row index of the frame    (vertical   → y)
        vec2 uv = (UV + vec2(custom.g, custom.b)) * cell_size;

        COLOR = texture(TEXTURE, uv);
    }
    else {
        COLOR = vec4(0.0, 0.0, 0.0, 0.0);
    }
}
