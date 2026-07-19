// ================================================================
// Site.js - Portfolio Interactivity
// Highlights active sidebar link based on current page
// ================================================================

(function () {
    'use strict';

    // ----------------------------------------------------------------
    // Active Link: Highlight sidebar link matching the current page
    // ----------------------------------------------------------------
    var currentPath = window.location.pathname.toLowerCase();
    var sidebarLinks = document.querySelectorAll('.sidebar-nav .nav-link');
    var mobileLinks = document.querySelectorAll('.sidebar-nav-mobile .nav-link');

    function highlightActiveLink(links) {
        links.forEach(function (link) {
            var href = link.getAttribute('href');
            if (href) {
                var linkPath = href.toLowerCase();
                // Check if the current page matches the link
                if (currentPath === linkPath || currentPath === linkPath + '/') {
                    link.classList.add('active');
                } else if (currentPath === '/' && (linkPath === '/' || linkPath.indexOf('/home/index') !== -1 || linkPath.indexOf('/home') === 0 && linkPath.split('/').length <= 3 && linkPath.indexOf('/home/') === -1)) {
                    // Home page match
                    if (linkPath === '/' || linkPath === '/home' || linkPath === '/home/index') {
                        link.classList.add('active');
                    }
                } else {
                    link.classList.remove('active');
                }
            }
        });
    }

    highlightActiveLink(sidebarLinks);
    highlightActiveLink(mobileLinks);

    // ----------------------------------------------------------------
    // Intersection Observer: Animate sections on scroll into view
    // ----------------------------------------------------------------
    var sections = document.querySelectorAll('section[id]');
    var observerOptions = {
        root: null,
        rootMargin: '0px',
        threshold: 0.1
    };

    var observer = new IntersectionObserver(function (entries) {
        entries.forEach(function (entry) {
            if (entry.isIntersecting) {
                entry.target.classList.add('section-visible');
            }
        });
    }, observerOptions);

    sections.forEach(function (section) {
        section.classList.add('section-hidden');
        observer.observe(section);
    });

})();
