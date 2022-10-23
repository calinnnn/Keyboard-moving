public boolean onKeyDown(int keyCode, KeyEvent msg)
{
    if (keyCode == KeyEvent.KEYCODE_DPAD_UP)
    {
        renderer.mY -= 1;
        requestRender();
        return (true);
    }

    if (keyCode == KeyEvent.KEYCODE_DPAD_DOWN)
    {
        renderer.mY += 1;
        requestRender();
        return (true);
    }

    if (keyCode == KeyEvent.KEYCODE_DPAD_LEFT)
    {
        renderer.mX -= 1;
        requestRender();
        return (true);
    }

    if (keyCode == KeyEvent.KEYCODE_DPAD_RIGHT)
    {
        renderer.mX += 1;
        requestRender();
        return (true);
    }

    return true;
}

public void onDrawFrame(GL10 gl)
{
    gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
    gl.glClear(GL10.GL_COLOR_BUFFER_BIT | GL10.GL_DEPTH_BUFFER_BIT);

    enable2d(gl);
    gl.glMatrixMode(GL10.GL_MODELVIEW);
    gl.glLoadIdentity();
    //gl.glTranslatef(0, 0, -3.0f);
    gl.glTranslatef(mX, 0, -3.0f);
    gl.glTranslatef(0, mY, -3.0f);
    gl.glRotatef(mAngleX, 0, 1, 0);
    gl.glRotatef(mAngleY, 1, 0, 0);
    gl.glEnableClientState(GL10.GL_VERTEX_ARRAY);
    gl.glEnableClientState(GL10.GL_COLOR_ARRAY);

    drawTriangle(gl, 160.0f, 100.0f, 110.0f, 200.0f, 210.0f, 200.0f, 1.0f, 1.0f, 1.0f);
    drawTriangle(gl, 110.0f, 200.0f, 60.0f, 300.0f, 160.0f, 300.0f, 1.0f, 1.0f, 1.0f);
    drawTriangle(gl, 210.0f, 200.0f, 160.0f, 300.0f, 260.0f, 300.0f, 1.0f, 1.0f, 1.0f);
    disable2d(gl);
}