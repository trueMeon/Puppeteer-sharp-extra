() => {
    try {
        width = window.innerWidth;
        height = window.innerHeight;

        const windowFrame = 85; // probably OS and WM dependent
        window.outerWidth = width;
        window.outerHeight = height;
        
        window.innerWidth = width;
        window.innerHeight = height - windowFrame;
    } catch (err) { }
}