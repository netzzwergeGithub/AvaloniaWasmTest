let gl = null;

export function initWebGL(canvasId) {
    const canvas = document.getElementById(canvasId);
    console.log('canvas: ', canvas);
    if (!canvas) return false;
    gl = canvas.getContext('webgl');
    console.log('context', gl);
    return gl !== null;
}

export function clearColor(r, g, b, a) {
    console.log('clear: ',gl);
    if (!gl) return;
    gl.clearColor(r, g, b, a);
    gl.clear(gl.COLOR_BUFFER_BIT);
}