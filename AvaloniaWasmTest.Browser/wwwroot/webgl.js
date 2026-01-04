export function initWebGL(canvasId) {

    const canvas = document.getElementById(canvasId);

    const gl = canvas.getContext('webgl');

    return gl !== null;

}

